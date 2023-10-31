using System;
using System.Collections.Generic;
using Xunit;
using System.Linq;

namespace _12_DebuggingChallenge.Tests
{
    public class ProgramTest
    {
        public static readonly IEnumerable<object[]> _testNameList = new List<object[]>{
          new object[] {new List<string> {"Marielle", "Mars", "Bebs", "Casey"}, 2},
          new object[] {new List<string> {"Jacob", "Mark", "Marielle", "Nick", "Fred", "Pushpinder"}, 3},
          new object[] {new List<string> {"Kevin", "Dale", "Spencer", "Noah", "Achilles", "Omar", "Tyrel", "Gordon"}, 4},
          new object[] {new List<string> {"Eden", "Kyra", "Aj", "Paul", "Anna", "Janel", "Jeah"}, 2},
          new object[] {new List<string> {"Melissa", "Mica", "Carlo", "Miriam", "Catherine", "Celina", "Benito", "CB", "Isang"}, 3}
        };
        public static readonly IEnumerable<object[]> _testNameList2 = new List<object[]>{
          new object[] {new List<string> {"Marielle", "Mars", "Bebs", "Casey"}},
          new object[] {new List<string> {"Jacob", "Mark", "Marielle", "Nick", "Fred", "Pushpinder"}},
          new object[] {new List<string> {"Kevin", "Dale", "Spencer", "Noah", "Achilles", "Omar", "Tyrel", "Gordon"}},
          new object[] {new List<string> {"Eden", "Kyra", "Aj", "Paul", "Anna", "Janel", "Jeah"}},
          new object[] {new List<string> {"Melissa", "Mica", "Carlo", "Miriam", "Catherine", "Celina", "Benito", "CB", "Isang"}}
        };
        public static readonly IEnumerable<object[]> _testInvalidNameList = new List<object[]>{
          new object[] {null, 2},
          new object[] {new List<string> {"Jacob", "Mark", "Marielle", "Nick", "Fred", "Pushpinder"}, 25},
          new object[] {new List<string> {"Melissa", "Mica", "Carlo", "Miriam", "Catherine", "Celina", "Benito", "CB", "Isang"}, -3}
        };

        [Theory]
        [MemberData(nameof(_testNameList))]
        public void GetPartyFriendsShouldReturnShortNames(List<string> friends, int count)
        {
            var result = Program.GetPartyFriends(friends, count);
            friends.Sort((x, y) => x.Length.CompareTo(y.Length));
            Assert.Equal(friends.GetRange(0, count), result);
        }

        [Theory]
        [MemberData(nameof(_testInvalidNameList))]
        public void GetPartyFriendsShouldReturnExceptions(List<string> friends, int count)
        {
            Assert.ThrowsAny<Exception>(() => Program.GetPartyFriends(friends, count));
        }

        [Theory]
        [MemberData(nameof(_testNameList2))]
        public void GetPartyFriendShouldReturnShortestName(List<string> friends)
        {
            var result = Program.GetPartyFriend(friends);
            friends.Sort((x, y) => x.Length.CompareTo(y.Length));
            Assert.Equal(friends.First(), result);
        }
    }
}
