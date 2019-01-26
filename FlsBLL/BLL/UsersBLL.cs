using System.Collections.ObjectModel;
using FlsCommon;
using FlsCommon.DTO;
using FlsDAL.DAL;

namespace FlsBLL.BLL
{
    public class UsersBLL
    {
        public ObservableCollection<UserDto> GetUsersList()
        {
            return UsersDAL.GetAllUsers();
        }

        public OperationResult<UserDto> ConnectUser(UserDto user)
        {
            return UsersDAL.ConnectUser(user);
        }

        public OperationResult<UserDto> DeleteUser(UserDto user)
        {
            return UsersDAL.DeleteUser(user);
        }

        public OperationResult<UserDto> AddOrUpdateUser(UserDto user)
        {
            return UsersDAL.AddOrUpdateUser(user);
        }
    }
}