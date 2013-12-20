﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    class Match : EntityObject
    {
        private int _coupeId;
        public int CoupeId
        {
            get { return _coupeId; }
            set { _coupeId = value; }
        }

        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private Equipe _equipeDomicile;
        internal Equipe EquipeDomicile
        {
            get { return _equipeDomicile; }
            set { _equipeDomicile = value; }
        }

        private Equipe _equipeVisiteur;
        internal Equipe EquipeVisiteur
        {
            get { return _equipeVisiteur; }
            set { _equipeVisiteur = value; }
        }

        private double _prix;
        public double Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        private int _scoreEquipeDomicile;
        public int ScoreEquipeDomicile
        {
            get { return _scoreEquipeDomicile; }
            set { _scoreEquipeDomicile = value; }
        }

        private int _scoreEquipeVisiteur;
        public int ScoreEquipeVisiteur
        {
            get { return _scoreEquipeVisiteur; }
            set { _scoreEquipeVisiteur = value; }
        }

        private Stade _stade;
        internal Stade Stade
        {
            get { return _stade; }
            set { _stade = value; }
        }

        public Match(int inId, int inCoupeID, DateTime inDate, Equipe inDom, Equipe inVisiteur, double inPrix, int inSED, int inSEV, Stade inStade) 
            : base(inId)
        {
            this.CoupeId = inCoupeID;
            this.Date = inDate;
            this.EquipeDomicile = inDom;
            this.EquipeVisiteur = inVisiteur;
            this.Prix = inPrix;
            this.ScoreEquipeDomicile = inSED;
            this.ScoreEquipeVisiteur = inSEV;
            this.Stade = inStade;
        }
    }
}
