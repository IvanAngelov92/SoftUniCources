using System;
using System.Collections.Generic;

class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }

    public Song(string typeList, string name, string time)
    {
        TypeList = typeList;
        Name = name;
        Time = time;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        List<Song> songs = new List<Song>();

        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split('_');
            string typeList = input[0];
            string name = input[1];
            string time = input[2];

            Song song = new Song(typeList, name, time);
            songs.Add(song);
        }

        string filter = Console.ReadLine();

        if (filter == "all")
        {
            foreach (Song song in songs)
            {
                Console.WriteLine(song.Name);
            }
        }
        else
        {
            foreach (Song song in songs)
            {
                if (song.TypeList == filter)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}