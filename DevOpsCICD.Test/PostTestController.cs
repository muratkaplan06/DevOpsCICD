using System;
using System.Collections.Generic;
using DevOpsCICD.Controllers;
using DevOpsCICD.Data;
using DevOpsCICD.Models;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace DevOpsCICD.Test
{
    public class PostTestController
    {
        private readonly PostRepository _repository;

        public PostTestController()
        {
            _repository = new PostRepository();
        }
        
        [Fact]
        public void Test_Index_ViewResult()
        {
           //Arrange
           var controller = new HomeController(this._repository);
           //Act
           var result = controller.Index();
           //Assert
           Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Test_Index_Return_Result()
        {
            //Arrange
            var controller = new HomeController(this._repository);
            //Act
            var result = controller.Index();
            //Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void Test_Index_GetPosts_MatchData()
        {
            //Arrange
            var controller = new HomeController(this._repository);
            //Act
            var result = controller.Index();
            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<PostViewModel>>(viewResult.ViewData.Model);
            Assert.Equal(3,model.Count);
            Assert.Equal(1,model[0].PostId);
            Assert.Equal("DevOps Title 1",model[0].Title);
        }
    }
}
