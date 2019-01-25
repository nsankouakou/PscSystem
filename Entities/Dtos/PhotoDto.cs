using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities.Models.Dto
{
    public class PhotoDto
    {
        public int Id { get; set; }

        public string Extension { get; set; }

        public string CheminFichier { get; set; }

        public int? StatusCode { get; set; }

        public ICollection<Agent> Agent { get; set; }

        public string Token { get; set; }

        public static PhotoDto FromModel(Photo model)
        {
            return new PhotoDto()
            {
                Id = model.Id, 
                Extension = model.Extension, 
                CheminFichier = model.CheminFichier, 
                StatusCode = model.StatusCode, 
                Agent = model.Agent, 
            }; 
        }

        public Photo ToModel()
        {
            return new Photo()
            {
                Id = Id, 
                Extension = Extension, 
                CheminFichier = CheminFichier, 
                StatusCode = StatusCode, 
                Agent = Agent, 
            }; 
        }
    }
}