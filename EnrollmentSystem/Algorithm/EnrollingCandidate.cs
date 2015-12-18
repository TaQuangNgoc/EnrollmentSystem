using System;
using System.Collections.Generic;
using System.Linq;

namespace EnrollmentSystem.Algorithm
{
    class EnrollingCandidate : IComparable
    {
        private int currentOption;
        private EnrollingMajor[] options;
        private decimal[] scores;

        private Candidate candidate;

        internal EnrollingMajor CurrentOption
        {
            get
            {
                return options[currentOption];
            }
        }

        internal decimal CurrentScore
        {
            get
            {
                return scores[currentOption];
            }
        }

        internal bool HasUnusedOptions
        {
            get
            {
                return currentOption + 1 < options.Length;
            }
        }

        public EnrollingCandidate(Candidate candidate, IEnumerable<EnrollingMajor> options, IEnumerable<decimal> scores)
        {
            this.options = options.ToArray();
            this.scores = scores.ToArray();

            this.candidate = candidate;

            currentOption = -1;
        }

        public void MoveOnToNextOption()
        {
            currentOption++;
        }

        // implement IComparable in order to sort
        int IComparable.CompareTo(object obj)
        {
            var other = (EnrollingCandidate)obj;
            return - CurrentScore.CompareTo(other.CurrentScore);
        }

        public void SaveChanges()
        {
            var options = candidate.Options.First();
            var combinations = new[] { options.MajorSubjectCombination,
                                       options.MajorSubjectCombination1,
                                       options.MajorSubjectCombination2,
                                       options.MajorSubjectCombination3 };

            int admittingID = combinations[currentOption].SubjectCombinationID;
            candidate.AdmittingMajorSubjectCombinationID = admittingID;
            candidate.AdmissionMark = CurrentScore;
        }
    }
}
