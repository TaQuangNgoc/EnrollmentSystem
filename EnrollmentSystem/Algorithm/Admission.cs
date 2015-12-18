using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentSystem.Algorithm
{
    public class Admission
    {
        EnrollingMajor[] majors;
        EnrollingCandidate[] candidates;

        public void StartAdmission()
        {
            using (var entities = new EnrollmentSystemEntities())
            {
                entities.Configuration.AutoDetectChangesEnabled = false;

                var majorDictionary = new Dictionary<Major, EnrollingMajor>();
                foreach (var major in entities.Majors)
                    majorDictionary.Add(major, new EnrollingMajor(major));

                this.majors = majorDictionary.Values.ToArray();

                var candidateList = new List<EnrollingCandidate>();
                foreach (var candidate in entities.Candidates)
                {
                    var options = from option in GetOptions(candidate)
                                  select majorDictionary[option];

                    var scores = GetScores(candidate);

                    Debug.Assert(options.Count() == scores.Count());

                    candidateList.Add(new EnrollingCandidate(candidate, options, scores));
                }
                this.candidates = candidates.ToArray();

                RunAlgorithm();
                SaveResults();

                entities.SaveChanges();
            }
        }

        private IEnumerable<Major> GetOptions(Candidate candidate)
        {
            Option option;
            try
            {
                option = candidate.Options.First();
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentException("Candidate has no option.");
            }

            var combinations = new[] { option.MajorSubjectCombination,
                                       option.MajorSubjectCombination1,
                                       option.MajorSubjectCombination2,
                                       option.MajorSubjectCombination3 };

            foreach (var combination in combinations)
                if (combination != null)
                    yield return combination.Major;
                else
                    yield break;
        }

        private IEnumerable<decimal> GetScores(Candidate candidate)
        {
            Option option;
            try
            {
                option = candidate.Options.First();
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentException("Candidate has no option.");
            }

            var combinations = new[] { option.MajorSubjectCombination,
                                       option.MajorSubjectCombination1,
                                       option.MajorSubjectCombination2,
                                       option.MajorSubjectCombination3 };

            decimal bonus = 0;
            if (candidate.HasPrivilege)
                bonus += 1;
            bonus += candidate.Region.Bonus;
            bonus += candidate.Beneficiary.Bonus;

            foreach (var combination in combinations)
                if (combination != null)
                    yield return ScoreFromCombination(candidate, combination.SubjectCombination) + bonus;
                else
                    yield break;
        }

        private decimal ScoreFromCombination(Candidate candidate, SubjectCombination combination)
        {
            decimal score1 = ScoreFromSubject(candidate, combination.Subject),
                    score2 = ScoreFromSubject(candidate, combination.Subject1),
                    score3 = ScoreFromSubject(candidate, combination.Subject2);

            if (!combination.HasMainSubject)
                return (score1 + score2 + score3) / 3;

            return (2 * score1 + score2 + score3) / 4;
        }

        private decimal ScoreFromSubject(Candidate candidate, Subject subject)
        {
            var query = from mark in candidate.Marks
                        where mark.Subject == subject
                        select mark.Score;

            Debug.Assert(query.Count() == 1);

            return query.First();
        }

        private void RunAlgorithm()
        {
            var queue = new Queue<EnrollingCandidate>(candidates);

            while (queue.Count > 0)
            {
                var candidate = queue.Dequeue();
                candidate.MoveOnToNextOption();
                var major = candidate.CurrentOption;

                if (major.CheckIfCandidateIsTemporarilyQualified(candidate))
                {
                    major.AddToTempListAndSort(candidate);
                    var removedCandidates = major.PopFromTempList();

                    foreach (var removed in removedCandidates)
                        if (removed.HasUnusedOptions)
                            queue.Enqueue(removed);
                }
                else
                    if (candidate.HasUnusedOptions)
                    queue.Enqueue(candidate);
            }
        }

        private void SaveResults()
        {
            foreach (var major in majors)
                major.SaveChanges();
        }
    }
}
