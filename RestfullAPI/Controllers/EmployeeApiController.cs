using RestfullAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestfullAPI.Controllers
{
    public class EmployeeApiController : ApiController
    {
        // GET api/employeeapi
        public IEnumerable<Team> GetTeamList()
        {
            List<Team> lstTeam = new List<Team>();

            Team team = new Team();
            team.TeamID = 1;
            team.TeamName = "Inspec";
            lstTeam.Add(team);
            team = new Team();
            team.TeamID = 2;
            team.TeamName = "IET ES+";
            lstTeam.Add(team);
            team = new Team();
            team.TeamID = 3;
            team.TeamName = "IET TV";
            lstTeam.Add(team);
            return lstTeam;
        }

        // GET api/employeeapi/5
        public Team Get(int id)
        {
            Team team = new Team();
            team.TeamID = 1;
            team.TeamName = "Inspec";
            return team;
        }

     
    }
}
