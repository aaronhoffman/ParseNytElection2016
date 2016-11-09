using Newtonsoft.Json;
using ParseNytElection2016.Data;
using ParseNytElection2016.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseNytElection2016
{
    public class NytParser
    {
        public NytParser()
        {

        }

        public void ParseJsonFile(string filenameAndPath)
        {
            var jsoncontent = File.ReadAllText(filenameAndPath);

            var stateResults = JsonConvert.DeserializeObject<RootObject[]>(jsoncontent);

            var ctx = new Election2016Context("Server=.;Database=election2016;Integrated Security=SSPI;");
            ctx.Configuration.AutoDetectChangesEnabled = false;

            foreach (var state in stateResults)
            {
                foreach (var county in state.counties)
                {
                    var cr = new CountyResult();

                    cr.StateCode = state.state_id;
                    cr.StateSlug = state.state_slug;
                    cr.StateElectoralVotes = state.electoral_votes;
                    cr.StatePrecinctsReporting = state.precincts_reporting;
                    cr.StatePrecinctsTotal = state.precincts_total;
                    cr.CountyFips = county.fips;
                    cr.CountyName = county.name;
                    cr.CountyTotalVotes = county.votes;
                    cr.CountyPrecintsReporting = county.reporting;
                    cr.CountyPrecinctsTotal = county.precincts;
                    cr.EstVotesRemaining = county.est_votes_remaining;
                    cr.trumpd = county.results.trumpd;
                    cr.clintonh = county.results.clintonh;
                    cr.johnsong = county.results.johnsong;
                    cr.castled = county.results.castled;
                    cr.steinj = county.results.steinj;
                    cr.Other = (
                        county.results.de_la_fuenter +
                        county.results.mcmulline +
                        county.results.vacekd +
                        county.results.kahnl +
                        county.results.la_rivag +
                        county.results.kenistonc +
                        county.results.smithm +
                        county.results.kopitkek +
                        county.results.silvar +
                        county.results.maturenm +
                        county.results.scottr +
                        county.results.hoeflingt +
                        county.results.maldonadoj +
                        county.results.kotlikoffl +
                        county.results.atwoodf +
                        county.results.kennedya +
                        county.results.lyttleb +
                        county.results.soltysike +
                        county.results.hedgesj +
                        county.results.copelands +
                        county.results.giordanir +
                        county.results.mooreheadm +
                        county.results.skewesp +
                        county.results.jacobp +
                        county.results.whitej +
                        county.results.duncanr +
                        county.results.none_of_these_candidates);

                    ctx.CountyResults.Add(cr);
                }
            }

            ctx.SaveChanges();
        }
    }
}