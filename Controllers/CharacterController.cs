using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.Runtime.InteropServices.ComTypes;
using System.IO;
using DnDCharacterCreator.Data;
using DnDCharacterCreator.Models;
using DnDCharacterCreator.Models.ViewModels;

namespace Capstone.controllers
{
    [Authorize]
    public class CharacterController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _usermanager;

        public CharacterController(ApplicationDbContext context, UserManager<ApplicationUser> usermanager)
        {
            _context = context;
            _usermanager = usermanager;
        }

        // get: characters
        public async Task<ActionResult> Index()
        {
            var user = await getcurrentuserasync();
            var characters = await _context.Character
                .Where(ch => ch.ApplicationUserId == user.Id)
                .ToListAsync();
            return View(characters);
        }

        // get: character/details/5
        public async Task<ActionResult> Details(int id)
        {
            var character = await _context.Character
                .FirstOrDefaultAsync(c => c.Id == id);
            return View(character);
        }

        // get: Character/create
        public ActionResult Create()
        {
            return View();
        }

        // post: character/create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CharacterDetailViewModel characterDetailViewModel)
        {
            try
            {
                var user = await getcurrentuserasync();

                var characterinstance = new Character
                {
                    CharacterName = characterDetailViewModel.Character.CharacterName,
                    PlayerName = characterDetailViewModel.Character.PlayerName,
                    Class = characterDetailViewModel.Character.Class,
                    Race = characterDetailViewModel.Character.Race,
                    Level = characterDetailViewModel.Character.Level,
                    Experience = characterDetailViewModel.Character.Experience,
                    MaxHp = characterDetailViewModel.Character.MaxHp,
                    CurrentHp = characterDetailViewModel.Character.CurrentHp,
                    HitDice = characterDetailViewModel.Character.HitDice,
                    ArmorClass = characterDetailViewModel.Character.ArmorClass,
                    Strength = characterDetailViewModel.Character.Strength,
                    Dexterity = characterDetailViewModel.Character.Dexterity,
                    Constitution = characterDetailViewModel.Character.Constitution,
                    Intelligence = characterDetailViewModel.Character.Intelligence,
                    Wisdom = characterDetailViewModel.Character.Wisdom,
                    Charisma = characterDetailViewModel.Character.Charisma,
                    ProficiencyBounus = characterDetailViewModel.Character.ProficiencyBounus,
                    Spells = characterDetailViewModel.Character.Spells,
                    Inventory = characterDetailViewModel.Character.Inventory,
                    Proficiencies = characterDetailViewModel.Character.Proficiencies,
                    Speed = characterDetailViewModel.Character.Speed,
                    SavingThrows = characterDetailViewModel.Character.SavingThrows,
                    Skills = characterDetailViewModel.Character.Skills,
                    Feats = characterDetailViewModel.Character.Feats,
                    Notes = characterDetailViewModel.Character.Notes
                };

                characterinstance.ApplicationUserId = user.Id;

                var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images");
                if (characterDetailViewModel.ImageFile != null)
                {
                    var fileName = Guid.NewGuid().ToString() + characterDetailViewModel.ImageFile.FileName;
                    characterDetailViewModel.ImagePath = fileName;
                    using (var fileStream = new FileStream(Path.Combine(uploadPath, fileName), FileMode.Create))
                    {
                        await characterDetailViewModel.ImageFile.CopyToAsync(fileStream);
                    }
                }

                _context.Character.Add(characterinstance);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // get: character/edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var character = await _context.Character.FindAsync(id);
            return View(character);
        }

        // post: character/edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Character character)
        {

            try
            {
                var user = await getcurrentuserasync();
                _context.Update(character);
                character.ApplicationUserId = user.Id;
                await _context.SaveChangesAsync();


            }
            catch (DbUpdateConcurrencyException)
            {

            }
            return RedirectToAction("Index", "Character");
        }

        // get: character/delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var character = await _context.Character.FirstOrDefaultAsync(ch => ch.Id == id);

            var loggedinuser = await getcurrentuserasync();

            if (character.ApplicationUserId != loggedinuser.Id)
            {
                return NotFound();
            }

            return View(character);
        }

        // post: character/delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, Character character)
        {
            try
            {

                _context.Character.Remove(character);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private Task<ApplicationUser> getcurrentuserasync() => _usermanager.GetUserAsync(HttpContext.User);
    }
}