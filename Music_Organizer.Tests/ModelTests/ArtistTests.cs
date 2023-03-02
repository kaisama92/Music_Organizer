using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class ArtistTests : IDisposable
  {
    public void Dispose()
    {
      Artist.ClearAll();
    }

    [TestMethod]
    public void ArtistConstructor_CreatesInstanceOfArtist_Artist()
    {
      Artist newArtist = new Artist("Lady Gaga");
      Assert.AreEqual(typeof(Artist), newArtist.GetType());
    }

    [TestMethod]
    public void GetArtistName_ReturnsArtistName_String()
    {
      string name = "Lady Gaga";
      Artist newArtist = new Artist(name);
      string result = newArtist.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetID_ReturnsArtistID_Int()
    {
      string name = "Lady Gaga";
      Artist newArtist = new Artist(name);
      int result = newArtist.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllArtistObjects_ArtistList()
    {
      string name01 = "Lady Gaga";
      string name02 = "Britney Spears";
      Artist newArtist1 = new Artist(name01);
      Artist newArtist2 = new Artist(name02);
      List<Artist> newList = new List<Artist> { newArtist1, newArtist2};
      List<Artist> result = Artist.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectArtist_Artist()
    {
      string name01 = "Lady Gaga";
      string name02 = "Britney Spears";
      Artist newArtist1 = new Artist(name01);
      Artist newArtist2 = new Artist(name02);
      Artist result = Artist.Find(2);
      Assert.AreEqual(newArtist2, result);
    }

    [TestMethod]
    public void AddSong_AssociatesSongWithArtist_SongList()
    {
      string title = "Toxic";
      Song newSong = new Song(title, "Britney Spears");
      List<Song> newList = new List<Song> { newSong };
      string artist = "Britney Spears";
      Artist newArtist = new Artist(artist);
      newArtist.AddSong(newSong);
      List<Song> result = newArtist.Songs;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}