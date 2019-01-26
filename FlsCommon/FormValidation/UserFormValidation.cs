using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormotsCommon.DTO;

namespace FormotsCommon.FormValidation
{
    public class UserFormValidation
    {
        private UserDto userDtoToValidate;
        public UserFormValidation(UserDto userDto)
        {
            userDtoToValidate = userDto;
        }

        /// <summary>
        /// Returns true if this object has no validation errors.
        /// </summary>
        public bool IsValid
        {
            get
            {
                var validatedProperties = ValidatedProperties;

                foreach (var property in validatedProperties)
                {

                    if (GetValidationError(property) != null)
                    {
                        return false;
                    } // there is an error
                }

                return true;
            }
        }

        static readonly string[] ValidatedProperties =
        {
            "Login",
            "Password",
            "FirstName",
            "LastName"
        };

        public string GetValidationError2(string columnName)
        {
            if (columnName == "Login")
            {
                return ValidateLogin(userDtoToValidate.Login);
            }
            if (columnName == "FirstName")
            {
                return ValidateFirstName(userDtoToValidate.FirstName);
            }
            if (columnName == "LastName")
            {
                return ValidateLastName(userDtoToValidate.LastName);
            }
            if (columnName == "Password")
            {
                return ValidatePassword(userDtoToValidate.Password);
            }

            return null;
        }

        private string GetValidationError(string propertyName)
        {
            string error = null;

            switch (propertyName)
            {
                case "Login":
                    error = ValidateLogin(userDtoToValidate.Login);
                    break;

                case "FirstName":
                    error = ValidateFirstName(userDtoToValidate.FirstName);
                    break;

                case "LastName":
                    error = ValidateLastName(userDtoToValidate.LastName);
                    break;

                case "Password":
                    error = ValidatePassword(userDtoToValidate.Password);
                    break;

                default:
                    error = null;
                    throw new Exception("Unexpected property being validated on Service");
            }

            return error;
        }

        public string ValidateLogin(string login)
        {
            if (string.IsNullOrEmpty(login))
            {
                return "Le nom du compte ne doit pas être vide";
            }
            return null;
        }
        public string ValidateFirstName(string firstName)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                var error = "Le nom de l'utilisateur ne doit pas être vide";
                return error;
            }
            return null;
        }

        public string ValidateLastName(string lastName)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                var error = "Le prénom de l'utilisateur ne doit pas être vide";
                return error;
            }
            return null;
        }

        public string ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                var error = "Le mot de passe de l'utilisateur ne doit pas être vide";
                return error;
            }
            return null;
        }

        public string this[string columnName]
        {
            get { return GetValidationError2(columnName); }
        }

        public string Error { get; }
    }
}
