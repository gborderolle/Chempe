﻿using Domain.Chempe;
using Domain.Context;
using Microsoft.Extensions.Configuration;
using Services.DTOs;
using Services.Utils;
using System;
using System.Collections.Generic;

namespace Services.Chempe
{
    public class Service_Photo
    {
        private readonly Chempedb_context _chempedb_context;
        private readonly IConfiguration _configuration;
        private readonly Service_Person _service_Person;

        Configurations _configurations = new();

        public Service_Photo(Chempedb_context chempedb_context, IConfiguration configuration, Service_Person service_Person)
        {
            _chempedb_context = chempedb_context;
            _configuration = configuration;
            _service_Person = service_Person;
        }

        public DTO_Photo UploadNewPhoto(string identification, string photo_description)
        {
            Photo photo1 = null;
            if (!string.IsNullOrWhiteSpace(identification) && !string.IsNullOrWhiteSpace(photo_description))
            {
                int count_photos = _service_Person.Get_CountTotalPhotosByIdentification(identification);

                photo1 = new(photo_description, identification, null, count_photos);
                //_chempedb_context.Photo.Add(photo1);
            }
            return Utls.mapper.Map<DTO_Photo>(photo1);
        }

        internal List<Photo> ConverDTOList_toList(List<DTO_Photo> list_dto_photos)
        {
            List<Photo> list_photos = new();
            if (list_dto_photos != null && list_dto_photos.Count > 0)
            {
                foreach (DTO_Photo dto_photo in list_dto_photos)
                {
                    Photo photo = new Photo();
                    photo = Utls.mapper.Map<Photo>(dto_photo);
                    list_photos.Add(photo);
                }
            }
            return list_photos;
        }
    }
}
