using Infrastructure.Crosscutting.Localization;
using System;
using System.Collections.Generic;

namespace Domain.Seedwork
{
    /// <summary>
	/// The custom exception for validation errors
	/// </summary>
	public class DomainValidationErrorsException
        : Exception
    {
        #region Properties

        IEnumerable<string> _validationErrors;
        /// <summary>
        /// Get or set the validation errors messages
        /// </summary>
        public IEnumerable<string> ValidationErrors
        {
            get
            {
                return _validationErrors;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Create new instance of Application validation errors exception
        /// </summary>
        /// <param name="validationErrors">The collection of validation errors</param>
        public DomainValidationErrorsException(IEnumerable<string> validationErrors)
            : base(LocalizationFactory.CreateLocalResources().GetStringResource(LocalizationKeys.Domain.validation_Exception))
        {
            _validationErrors = validationErrors;
        }

        #endregion
    }
}
