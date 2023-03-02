using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrganizer.Models;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class SongTests : IDisposable
  {
    public void Dispose()
    {
      Song.ClearAll();
    }

    [TestMethod]
    public void SongConstructor_CreatesInstanceOfSong_Song()
    {
      Song newSong = new Song("hello", "MyNameIs");
      Assert.AreEqual(typeof(Song), newSong.GetType());
    }

    [TestMethod]
    public void GetSongName_ReturnsSongName_String()
    {
      string songName = "hello";
      Song newSong = new Song(songName, "MyNameIs");
      string result = newSong.SongName;

      Assert.AreEqual(songName, result);
    }

    [TestMethod]
    public void SetSongName_SetsSongname_String()
    {
      string songName = "hello";
      Song newSong = new Song(songName, "MyNameIs");

      string updatedSongName = "goodbye";
      newSong.SongName = updatedSongName;
      string result = newSong.SongName;

      Assert.AreEqual(updatedSongName, result);
    }

    [TestMethod]
    public void GetArtistName_ReturnsArtistName_String()
    {
      string artistName = "MyNameIs";
      Song newSong = new Song("hello", artistName);
      string result = newSong.ArtistName;

      Assert.AreEqual(artistName, result);
    }

    [TestMethod]
    public void SetArtistName_SetsArtistName_String()
    {
      string artistName = "MyNameIs";
      Song newSong = new Song("hello", artistName);

      string updatedName = "YourNameIs";
      newSong.ArtistName = updatedName;
      string result = newSong.ArtistName;

      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      List<Song> newSong = new List<Song> {};

      List<Song> result = Song.GetAll();

      CollectionAssert.AreEqual(newSong, result);
    }

    [TestMethod]
    public void GetAll_ReturnsSongs_SongsList()
    {
      string songName1 = "hello";
      string artistName1 = "MyNameIs";
      string songName2 = "goodbye";
      string artistName2 = "YourNameIs";
      Song newSong1 = new Song(songName1, artistName1);
      Song newSong2 = new Song(songName2, artistName2);
      List<Song> newList = new List<Song> {newSong1, newSong2};

      List<Song> result = Song.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}