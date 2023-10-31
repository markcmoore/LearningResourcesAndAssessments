using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Linq;
 
// the beginning
namespace _12_DebuggingChallenge
{
 
    public class Program
    {
        /// <summary>
        /// This BUGGY program should evaluate the List<string> by name.Length and 
        /// choose from the List<string> the number of friends requested by shortest name.
        /// Ex.!-- If 3 is passed into GetPartyFriends, teh 3 friends with 
        /// the shortest names get chosen.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var friends = new List<string> { "Maria", "Joe", "Michelle", "Andy", "Frank", "Carlos", "Angelina" };//this is the list of friends that will be evaluated 
            var partyFriends = GetPartyFriends(friends, 3);//get the 3 friends with the shortest names. Names of equal length are chosen on a first come first served basis.
            foreach (var name in partyFriends)//print the desired number of friends with the shortest names to the 
            {
                Console.WriteLine(name);
            }
        }

        /// <summary>
        /// This method has a bug.
        /// This method returns aList<string> of the desired number of names that were the shortest.
        /// </summary>
        /// <param name="list" type="List<string>"></param>
        /// <param name="count" type="int"></param>
        /// <returns></returns>
        public static List<string> GetPartyFriends(List<string> list, int count)//BUG - what if count is greater than 'list.Count'?
        {
            //BUG - what if the list is empty?
            if(list == null)
            {
                throw new NullReferenceException("The list is empty.");// Handle this exception in the calling method
            }

            //BUG - Check to make sure the number of friends requested is not more than the number of friends available. 
           /*  if(count > list.Count || count < 1)
            {
                 throw new ArgumentOutOfRangeException("count", $"The 'count' variable ({count}), > list.Count ({list.Count}) OR is less than 1"); //Should be handled by calling method
            } */
            // var buffer = new List<string>(list);//BUG - You need to create this buffer to delete names from so that the original list isn't deleted.
            var partyFriends = new List<string>();//save the 
            while(partyFriends.Count < count)//potential problem. If count < partyFriends.Count
            {
                var currentFriend = GetPartyFriend(list);//BUG - get the shortest name on the list.
                partyFriends.Add(currentFriend);//add that name to the list
                list.Remove(currentFriend);//BUG - change to buffer from list
            }
            return partyFriends;//return the list with 'count' number of names
        }
 
        /// <summary>
        /// This method has a bug. Takes a List<string> and returns the shortest name from the list
        /// </summary>
        /// <param name="list"></param>
        /// <returns>string</returns>
        public static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];//load the current shortest name
            for(var i = 0; i<list.Count; i++)//iterate over the list.
            {
                if(list[i].Length > shortestName.Length)//BUG - intentional logical bug here. should be '<'
                {
                    shortestName = list[i];//if the name in the list is shorter than the current shortestName.
                }
            }
            return shortestName;
            //return the shortest name found after iterating over the list
            
        }
    }//end of program
}//end of namespace