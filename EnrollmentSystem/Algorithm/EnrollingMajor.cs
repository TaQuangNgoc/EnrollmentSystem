using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace EnrollmentSystem.Algorithm
{
    class EnrollingMajor
    {
        private List<EnrollingCandidate> tempAdmittedCandidates;
        private int quota;
        private decimal cutOff;

        private Major major;

        public EnrollingMajor(Major major)
        {
            this.major = major;

            tempAdmittedCandidates = new List<EnrollingCandidate>();
            quota = this.major.Limit;
        }

        public bool CheckIfCandidateIsTemporarilyQualified(EnrollingCandidate candidate)
        {
            Debug.Assert(candidate.CurrentOption == this);

            if (tempAdmittedCandidates.Count < quota)
            {
                if (tempAdmittedCandidates.Count == quota - 1)
                    cutOff = candidate.CurrentScore;

                return true;
            }

            return candidate.CurrentScore >= cutOff;
        }

        public void AddToTempListAndSort(EnrollingCandidate candidate)
        {
            tempAdmittedCandidates.Add(candidate);
            tempAdmittedCandidates.Sort();
        }

        public IEnumerable<EnrollingCandidate> PopFromTempList()
        {
            if (tempAdmittedCandidates.Count <= quota)
                yield break;

            var lastCandidate = tempAdmittedCandidates.Last();
            while (lastCandidate.CurrentScore < cutOff)
            {
                RemoveLastCandidate();
                yield return lastCandidate;

                lastCandidate = tempAdmittedCandidates.Last();
            }
        }

        private void RemoveLastCandidate()
        {
            int lastIndex = tempAdmittedCandidates.Count - 1;
            tempAdmittedCandidates.RemoveAt(lastIndex);
        }

        public void SaveChanges()
        {
            foreach (var candidate in tempAdmittedCandidates)
                candidate.SaveChanges();

            major.CutOff = cutOff;
        }
    }
}
