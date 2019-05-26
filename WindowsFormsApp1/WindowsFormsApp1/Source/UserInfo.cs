using System;

namespace WindowsFormsApp1.Source
{
    public static class UserInfo
    {
        private static int uID = -1;
        private static string[] user = new string[2];

        /// <summary>
        /// Returns string with username if index 0 or usern surname if index 1.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>string</returns>
        public static string GetUser(short index)
        {
            if (index == 0 || index == 1)
                return user[index];
            else
                throw new Exception("Index out of range. To get name use 0, surname 1.");
        }

        /// <summary>
        /// Returns integer of user ID number.
        /// </summary>
        /// <returns></returns>
        public static int GetUser() => uID;

        /// <summary>
        /// Sets values of logged user's id, name and surname.
        /// </summary>
        /// <param name="uID"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        public static void SetUser(int uID, string name, string surname)
        {
            UserInfo.user[0] = name;
            UserInfo.user[1] = surname;
            UserInfo.uID = uID;
        }
    }
}
