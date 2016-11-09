using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseNytElection2016.Models
{
    public class CountyResult
    {
        public int CountyResultId { get; set; }
        public string StateCode { get; set; }
        public string StateSlug { get; set; }
        public int? StateElectoralVotes { get; set; }
        public int? StatePrecinctsReporting { get; set; }
        public int? StatePrecinctsTotal { get; set; }
        public string CountyFips { get; set; }
        public string CountyName { get; set; }
        public int? CountyTotalVotes { get; set; }
        public int? CountyPrecinctsTotal { get; set; }
        public int? CountyPrecintsReporting { get; set; }
        public int? EstVotesRemaining { get; set; }
        public int? trumpd { get; set; }
        public int? clintonh { get; set; }
        public int? johnsong { get; set; }
        public int? castled { get; set; }
        public int? steinj { get; set; }
        public int? Other { get; set; }
    }
}
