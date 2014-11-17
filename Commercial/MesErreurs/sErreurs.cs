﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MesErreurs
{
    public struct sErreurs
    {
        private String _MessageUtilisateur, _MessageApplication;
        public sErreurs(String mu, String ma)
        {
            _MessageUtilisateur = mu;
            _MessageApplication = ma;
        }
        public String MessageUtilisateur()
        {
            return (_MessageUtilisateur);
        }
        public String MessageApplication()
        {
            return (_MessageApplication);
        }
    }

}