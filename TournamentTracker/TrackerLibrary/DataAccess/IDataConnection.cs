﻿using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreatePrize(PrizeModel model);
        void CreateTeam(TeamModel model);
        void CreateTournament(TournamentModel model);
        void UpdateMatchup(MatchupModel model);
        List<TeamModel> GetTeam_All();
        void CreatePerson(PersonModel model);
        List<PersonModel> GetPerson_All();
        List<TournamentModel> GetTournament_All();
    }
}
