namespace ConsoleApp2;

using System;
using System.Collections.Generic;

class User{
    public int UserID;
    public string Name;
    public int Age;
    public List<int> FriendIDs;
    public User Next;

    public User(int userID, string name, int age){
        UserID = userID;
        Name = name;
        Age = age;
        FriendIDs = new List<int>();
        Next = null;
    }
}

class SocialMedia{
    private User head;
    public void AddUser(int userID, string name, int age){
        User newUser = new User(userID, name, age);
        if(head == null){
            head = newUser;
            return;
        }
        User temp = head;
        while (temp.Next != null){
            temp = temp.Next;
        }
        temp.Next = newUser;
    }

    public User SearchUserByID(int userID){
        User temp = head;
        while(temp != null){
            if(temp.UserID == userID){
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }

    public User SearchUserByName(string name){
        User temp = head;
        while(temp != null){
            if(temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase)){
                return temp;
            }
            temp = temp.Next;
        }
        return null;
    }

    public void AddFriend(int userID1, int userID2){
        User user1 = SearchUserByID(userID1);
        User user2 = SearchUserByID(userID2);

        if(user1 != null && user2 != null){
            if (!user1.FriendIDs.Contains(userID2)){
                user1.FriendIDs.Add(userID2);
            }
            if (!user2.FriendIDs.Contains(userID1)){
                user2.FriendIDs.Add(userID1);
            }
            Console.WriteLine("Friend added successfully");
        }
        else{
            Console.WriteLine("users not found");
        }
    }

    public void RemoveFriend(int userID1, int userID2){
        User user1 = SearchUserByID(userID1);
        User user2 = SearchUserByID(userID2);

        if (user1 != null && user2 != null)
        {
            user1.FriendIDs.Remove(userID2);
            user2.FriendIDs.Remove(userID1);
            Console.WriteLine("Friend connection removed successfully.");
        }
        else
        {
            Console.WriteLine("One or both users not found.");
        }
    }

    public void DisplayFriends(int userID)
    {
        User user = SearchUserByID(userID);
        if (user != null)
        {
            Console.WriteLine("Friends of " + user.Name + ":");
            foreach (int friendID in user.FriendIDs)
            {
                User friend = SearchUserByID(friendID);
                if (friend != null)
                {
                    Console.WriteLine("User ID: " + friend.UserID + ", Name: " + friend.Name);
                }
            }
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    public void FindMutualFriends(int userID1, int userID2)
    {
        User user1 = SearchUserByID(userID1);
        User user2 = SearchUserByID(userID2);

        if (user1 != null && user2 != null)
        {
            List<int> mutualFriends = new List<int>();
            foreach (int friend in user1.FriendIDs)
            {
                if (user2.FriendIDs.Contains(friend))
                {
                    mutualFriends.Add(friend);
                }
            }

            if (mutualFriends.Count > 0)
            {
                Console.WriteLine("Mutual friends of " + user1.Name + " and " + user2.Name + ":");
                foreach (int friendID in mutualFriends)
                {
                    User friend = SearchUserByID(friendID);
                    if (friend != null)
                    {
                        Console.WriteLine("User ID: " + friend.UserID + ", Name: " + friend.Name);
                    }
                }
            }
            else
            {
                Console.WriteLine("No mutual friends found.");
            }
        }
        else
        {
            Console.WriteLine("One or both users not found.");
        }
    }

    public int CountFriends(int userID)
    {
        User user = SearchUserByID(userID);
        return user != null ? user.FriendIDs.Count : 0;
    }

    public void DisplayAllUsers()
    {
        User temp = head;
        while (temp != null)
        {
            Console.WriteLine("User ID: " + temp.UserID + ", Name: " + temp.Name + ", Age: " + temp.Age + ", Friends: " + temp.FriendIDs.Count);
            temp = temp.Next;
        }
    }
}

class SocialMediaFriend{
    public static void Main(string[] args){
        SocialMedia friend = new SocialMedia();
        friend.AddUser(1, "Batman", 25);
        friend.AddUser(2, "Wonder Women", 24);
        friend.AddUser(3, "Spiderman", 23);
        friend.AddUser(4, "Joker", 26);

        Console.WriteLine("Adding Friend Connections:");
        friend.AddFriend(1, 2);
        friend.AddFriend(1, 3);
        friend.AddFriend(2, 3);
        friend.AddFriend(3, 4);

        Console.WriteLine("Displaying Friends of Batman:");
        friend.DisplayFriends(1);
        Console.WriteLine("Displaying Friends of Spiderman:");
        friend.DisplayFriends(3);
        Console.WriteLine("Finding Mutual Friends of Batman and Joker:");
        friend.FindMutualFriends(1, 3);
        Console.WriteLine("Counting Friends of Wonder Women:");
        Console.WriteLine("Wonder Women has " + friend.CountFriends(2) + " friends.");
        Console.WriteLine("Removing Friend Connection:");
        friend.RemoveFriend(1, 2);
        Console.WriteLine("Displaying Friends of Batman after removal:");
        friend.DisplayFriends(1);
        Console.WriteLine("All Users and Their Friend Counts:");
        friend.DisplayAllUsers();
    }
}
