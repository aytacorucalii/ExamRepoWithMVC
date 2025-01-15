using AutoMapper;
using Education.BL.DTOs.NewsDTOs;
using Education.BL.Services.Abstractions;
using Education.Core.Models;
using Education.DAL.Repositories.Abstractions;
using Microsoft.AspNetCore.Hosting;

namespace Education.BL.Services.Concretes;

public class NewsService : INewsService
{
    private readonly INewsRepository _newsRepository;
    private readonly IMapper _mapper;
    private readonly IWebHostEnvironment _webEnvironment;
    public NewsService(INewsRepository newsRepository, IWebHostEnvironment webEnvironment, IMapper mapper)
    {
        _newsRepository = newsRepository;
        _webEnvironment = webEnvironment;
        _mapper = mapper;
    }

    public async Task<ICollection<News>> GetAllAsync()
    {
        return await _newsRepository.GetAllAsync();
    }

    public async Task<News> GetByIdAsync(int id)
    {
        return await _newsRepository.GetByIdAsync(id);

    }

    public async Task<News> CreateAsync(NewsCreateDTO entityDTO)
    {
        News entity = _mapper.Map<News>(entityDTO);
        entity.CreatedDate = DateTime.UtcNow.AddHours(4);

        //img
        string rootPath = _webEnvironment.WebRootPath;

        //Eger mecbur olarsa asagidaki property mutleq dolu gelmelidir. Eger optional olarsa asagida ilk once Img-in null olub olmamasi yoxlanilmalidir
        if (entityDTO.Img is not null)
        {
            string fileName = entityDTO.Img.FileName;
            string folderPath = rootPath + "/upload/news/";
            string filePath = Path.Combine(folderPath, fileName);

            bool exists = Directory.Exists(folderPath);

            if (!exists)
            {
                Directory.CreateDirectory(folderPath);
            }

            string[] allowedExtensions = [".png", ".jpg", ".jpeg"];
            bool isAllowed = false;
            foreach (string extention in allowedExtensions)
            {
                if (Path.GetExtension(fileName) == extention)
                {
                    isAllowed = true;
                    break;
                }
            }
            if (!isAllowed)
            {
                throw new Exception("file is not supported");
            }

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await entityDTO.Img.CopyToAsync(stream);
            }
            entity.ImgUrl = fileName;
        }

        entity.ImgUrl = "randomPath";


        var create = await _newsRepository.CreateAsync(entity);
        await _newsRepository.SaveChangesAsync();
        return create;


    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _newsRepository.GetByIdAsync(id);
        _newsRepository.DeleteAsync(entity);
        await _newsRepository.SaveChangesAsync();
        return true;
    }


    public async Task<bool> Update(int id, NewsUpdateDTO entityDTO)
    {
        var updated = await _newsRepository.GetByIdAsync(id);
        News entity = _mapper.Map<News>(entityDTO);
        entity.UpdatedDate = DateTime.UtcNow.AddHours(4);
        entity.Id = id;
        _newsRepository.Update(updated);
        await _newsRepository.SaveChangesAsync();
        return true;
    }
}