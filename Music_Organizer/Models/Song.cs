using System;
using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Song
  {
    public string SongName { get; set; }
    public string ArtistName { get; set; }
    public int Id { get; }
    private static List<Song> _instances = new List<Song> { };
    // public List<Artist> Artists { get; set; }
    public Song(string songName, string artistName)
    {
      SongName = songName;
      ArtistName = artistName;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Song> GetAll()
    {
      return _instances;
    }
    public static Song Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}