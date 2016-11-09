using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseNytElection2016.Models
{

    public class Candidate
    {
        public string candidate_id { get; set; }
        public string candidate_key { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int order { get; set; }
        public string name_display { get; set; }
        public string party_id { get; set; }
        public bool winner { get; set; }
        public int votes { get; set; }
        public double percent { get; set; }
        public string percent_display { get; set; }
        public int electoral_votes { get; set; }
    }

    public class Results
    {
        public int trumpd { get; set; }
        public int clintonh { get; set; }
        public int johnsong { get; set; }
        public int castled { get; set; }
        public int steinj { get; set; }
        public int de_la_fuenter { get; set; }
        public int? mcmulline { get; set; }
        public int? vacekd { get; set; }
        public int? kahnl { get; set; }
        public int? la_rivag { get; set; }
        public int? kenistonc { get; set; }
        public int? smithm { get; set; }
        public int? kopitkek { get; set; }
        public int? silvar { get; set; }
        public int? maturenm { get; set; }
        public int? scottr { get; set; }
        public int? hoeflingt { get; set; }
        public int? maldonadoj { get; set; }
        public int? kotlikoffl { get; set; }
        public int? atwoodf { get; set; }
        public int? kennedya { get; set; }
        public int? lyttleb { get; set; }
        public int? soltysike { get; set; }
        public int? hedgesj { get; set; }
        public int? copelands { get; set; }
        public int? giordanir { get; set; }
        public int? mooreheadm { get; set; }
        public int? skewesp { get; set; }
        public int? jacobp { get; set; }
        public int? whitej { get; set; }
        public int? duncanr { get; set; }
        public int? none_of_these_candidates { get; set; }
    }

    public class County
    {
        public string fips { get; set; }
        public string name { get; set; }
        public int votes { get; set; }
        public int reporting { get; set; }
        public int precincts { get; set; }
        public int est_votes_remaining { get; set; }
        public Results results { get; set; }
    }

    public class RootObject
    {
        public string guid { get; set; }
        public string race_id { get; set; }
        public string race_slug { get; set; }
        public string path { get; set; }
        public string race_type { get; set; }
        public string election_type { get; set; }
        public string election_date { get; set; }
        public string race_name { get; set; }
        public string office { get; set; }
        public int nyt_rating { get; set; }
        public string state_id { get; set; }
        public string state_slug { get; set; }
        public bool has_incumbent { get; set; }
        public bool uncontested { get; set; }
        public bool report { get; set; }
        public string result { get; set; }
        public string result_source { get; set; }
        public int votes { get; set; }
        public int electoral_votes { get; set; }
        public string poll_display { get; set; }
        public string poll_time { get; set; }
        public int precincts_reporting { get; set; }
        public int precincts_total { get; set; }
        public string reporting_display { get; set; }
        public List<Candidate> candidates { get; set; }
        public string merge_strategy { get; set; }
        public List<County> counties { get; set; }
        public bool? gain { get; set; }
        public string lost_seat { get; set; }
    }

}
