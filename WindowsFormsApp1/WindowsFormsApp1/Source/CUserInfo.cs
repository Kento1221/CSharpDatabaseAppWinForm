using System;

namespace WindowsFormsApp1.Source
{
    public static class CUserInfo
    {
        private static int i_userID = -1;
        private static string[] ps_user = new string[2];

        /// <summary>
        /// Returns string with username if index 0 or usern surname if index 1.
        /// </summary>
        /// <param name="iIndex"></param>
        /// <returns>string</returns>
        public static string sGetUser(short iIndex)
        {
            if (iIndex == 0 || iIndex == 1)
                return ps_user[iIndex];
            else
                throw new Exception("Index out of range. To get name use 0, surname 1.");
        }

        /// <summary>
        /// Returns integer of user ID number.
        /// </summary>
        /// <returns></returns>
        public static int iGetUser() => i_userID;

        /// <summary>
        /// Sets values of logged user's id, name and surname.
        /// </summary>
        /// <param name="uID"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        public static void vSetUser(int uID, string name, string surname)
        {
            CUserInfo.ps_user[0] = name;
            CUserInfo.ps_user[1] = surname;
            CUserInfo.i_userID = uID;
        }
    }
}
