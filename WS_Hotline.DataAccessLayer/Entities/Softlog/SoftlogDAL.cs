﻿using WS_Hotline.DataAccessLayer.BDD;
using WS_Hotline.DTOLibrary.Entities.Softlog;
using WS_Hotline.Framework.AccesDonnees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace WS_Hotline.DataAccessLayer.Entities.Softlog
{
    /// <summary>
    /// Classe data acess layer de Softlog
    /// </summary>
    /// <remarks>ylouis - 11/07/2016 - Généré par Template T4 v1.0</remarks>
    public class SoftlogDAL : Repository<SoftlogDTO, DemoDbContext>
    {
        #region CSTR

        /// <summary>
        /// Constructeur vide
        /// </summary>
        /// <remarks>ylouis - 11/07/2016 - Création</remarks>
        public SoftlogDAL()
            : base(new DemoDbContext())
        {
            // yl - Gestion des Lien vers les autres tables
            this.GestionInclude();
        }

        /// <summary>
        /// Constructeur avec paramètre
        /// </summary>
        /// <param name="pContext">Context de base de données</param>
        /// <remarks>ylouis - 11/07/2016 - Création</remarks>
        public SoftlogDAL(DemoDbContext pContext)
            : base(pContext)
        {
            // yl - Gestion des Lien vers les autres tables
            this.GestionInclude();
        }

        #endregion

        #region Include

        /// <summary>
        /// Gestion des liens vers les autres tables
        /// </summary>
		/// <remarks>ylouis - 11/07/2016 - Création</remarks>
        private void GestionInclude()
        {
				
        }
		
        #endregion

    }
}
