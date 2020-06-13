using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Models.ViewModels
{
    public class CharacterDetailViewModel
    {
        public Character Character { get; set; }
        public string ImagePath { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
