using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        //Arrange
        string myPath = null;

        //Act + Assert
        Assert.That(() => ExtractFile.GetFile(myPath), Throws.ArgumentNullException);

    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        //Arrange
        string myPath = "";

        //Act + Assert
        Assert.That(() => ExtractFile.GetFile(myPath), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        //Arrange
        string? myPath = "C:\\Users\\guita\\OneDrive\\Desktop\\Exercises-Arrays-and-Lists.docx";
        //Act
        string result = ExtractFile.GetFile(myPath);

        //Assert
        Assert.That(result, Is.EqualTo("File name: Exercises-Arrays-and-Lists\nFile extension: docx"));
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        //Arrange
        string? myPath = "C:\\Users\\guita\\OneDrive\\Desktop\\Exercises-Arrays-and-Lists";
        //Act
        string result = ExtractFile.GetFile(myPath);

        //Assert
        Assert.That(result, Is.EqualTo("File name: Exercises-Arrays-and-Lists"));
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        //Arrange
        string? myPath = "C:\\Users\\guitar?!?\\OneDrive!!!\\Desktop\\Exercises-Arrays-and-Lists.docx";
        //Act
        string result = ExtractFile.GetFile(myPath);

        //Assert
        Assert.That(result, Is.EqualTo("File name: Exercises-Arrays-and-Lists\nFile extension: docx"));
    }
}
