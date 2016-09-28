﻿using System;
using System.Runtime.Serialization;
using Demo.DTOLibrary.Entities.User;

namespace Demo.DTOLibrary.Exception.UserException
{
    /// <summary>
    /// Exeption sur le Type User
    /// </summary>
	/// <remarks>ylouis - 11/07/2016 - Généré par Template T4 v1.0 </remarks>
    [Serializable]
    public class UserException : BaseDTOException<UserDTO>
    {
        #region Constructeur

		/// <summary>
        /// Constructeur
        /// </summary>
        /// <remarks>ylouis - 11/07/2016 - Généré par Template T4 v1.0 </remarks>
        public UserException(): base()
        { }

		 /// <summary>
        /// Constructeur avec message
        /// </summary>
        /// <param name="pMessage">Message de l'exception</param>
        /// <remarks>ylouis - 11/07/2016 - Généré par Template T4 v1.0 </remarks>
        public UserException(string pMessage): base(pMessage)
        { }

		/// <summary>
        /// Constructeur avec innner exception, message generer en automatique
        /// </summary>
        /// <param name="pInnrException">Inner exception</param>
        /// <remarks>ylouis - 11/07/2016 - Généré par Template T4 v1.0 </remarks>
		public UserException(System.Exception pInnrException)
            : base(pInnrException)
        { }

		/// <summary>
        /// Constructeur avec message et inner exception
        /// </summary>
        /// <param name="pMessage">Message</param>
        /// <param name="pInnrException">Inner exception</param>
        /// <remarks>ylouis - 11/07/2016 - Généré par Template T4 v1.0 </remarks>
        public UserException(string pMessage, System.Exception pInnrException)
            : base(pMessage, pInnrException)
        { }

		/// <summary>
        /// COnstructeur pour serialisation
        /// </summary>
        /// <param name="pInfo">Info</param>
        /// <param name="pContext">Context</param>
        /// <remarks>ylouis - 11/07/2016 - Généré par Template T4 v1.0 </remarks>
        protected  UserException(SerializationInfo pInfo, StreamingContext pContext): base (pInfo,pContext)
        { }

        #endregion
    }
}
		