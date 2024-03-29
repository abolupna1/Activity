﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AActivity.Data;
using AActivity.Models;

namespace AActivity.Areas.Sociologist.Controllers
{
    [Area("Sociologist")]
    public class TripBookingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TripBookingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Sociologist/TripBookings
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.TripBookings.Include(t => t.City).Include(t => t.SchedulingTripDetail);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Sociologist/TripBookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tripBooking = await _context.TripBookings
                .Include(t => t.City)
                .Include(t => t.SchedulingTripDetail)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tripBooking == null)
            {
                return NotFound();
            }

            return View(tripBooking);
        }

        // GET: Sociologist/TripBookings/Create
        [Route("Sociologist/TripBookings/Create/{tripId:int}")]
        public async Task< IActionResult> Create(int tripId)
        {
         var trip = await _context.SchedulingTripDetails
                .Include(e=>e.EducationalBody)
                .Include(t=>t.TripType)
                .FirstOrDefaultAsync(i=>i.Id == tripId);
          if(trip.TripTypeId == 3)
            {
                ViewData["CityId"] = new SelectList(_context.Cities.Skip(2), "Id", "LocationName");
                var setting = await _context.AppSettings.FirstOrDefaultAsync();

                ViewData["QtyDaysTrip"] = setting.QtyExternalDaysTrip;
            }
            else
            {
                int type = trip.TripTypeId == 1 ? 2 : 1;
                ViewData["CityId"] = new SelectList(_context.Cities.Where(i=>i.Id== type).Take(1), "Id", "LocationName", type);
                var setting = await _context.AppSettings.FirstOrDefaultAsync();

                ViewData["QtyDaysTrip"] = type == 2 ? setting.QtyOmrahDaysTrip : setting.QtyInternalDaysTrip;
            }
          
           ViewData["trip"] = trip;
           
            ViewData["SchedulingTripDetailId"] = new SelectList(_context.SchedulingTripDetails, "Id", "Id", trip.Id);
            return View();
        }

        // POST: Sociologist/TripBookings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Sociologist/TripBookings/Create/{tripId:int}")]
        public async Task<IActionResult> Create(int tripId,[Bind("Id,SchedulingTripDetailId,CityId,TripToDate,TripQtyDays,TripLocationName")] TripBooking tripBooking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tripBooking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            var trip = await _context.SchedulingTripDetails
                       .Include(e => e.EducationalBody)
                       .Include(t => t.TripType)
                       .FirstOrDefaultAsync(i => i.Id == tripId);
            if (trip.TripTypeId == 3)
            {
                ViewData["CityId"] = new SelectList(_context.Cities.Skip(2), "Id", "LocationName");
                var setting = await _context.AppSettings.FirstOrDefaultAsync();

                ViewData["QtyDaysTrip"] = setting.QtyExternalDaysTrip;
            }
            else
            {
                int type = trip.TripTypeId == 1 ? 2 : 1;
                ViewData["CityId"] = new SelectList(_context.Cities.Where(i => i.Id == type).Take(1), "Id", "LocationName", type);
                var setting = await _context.AppSettings.FirstOrDefaultAsync();

                ViewData["QtyDaysTrip"] = type == 2 ? setting.QtyOmrahDaysTrip : setting.QtyInternalDaysTrip;
            }

            ViewData["trip"] = trip;
            
            ViewData["SchedulingTripDetailId"] = new SelectList(_context.SchedulingTripDetails, "Id", "Id", trip.Id);
            return View(tripBooking);
        }

        // GET: Sociologist/TripBookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tripBooking = await _context.TripBookings.FindAsync(id);
            if (tripBooking == null)
            {
                return NotFound();
            }
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "LocationName", tripBooking.CityId);
            ViewData["SchedulingTripDetailId"] = new SelectList(_context.SchedulingTripDetails, "Id", "Id", tripBooking.SchedulingTripDetailId);
            return View(tripBooking);
        }

        // POST: Sociologist/TripBookings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SchedulingTripDetailId,CityId,TripToDate,TripQtyDays,TripLocationName")] TripBooking tripBooking)
        {
            if (id != tripBooking.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tripBooking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TripBookingExists(tripBooking.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CityId"] = new SelectList(_context.Cities, "Id", "LocationName", tripBooking.CityId);
            ViewData["SchedulingTripDetailId"] = new SelectList(_context.SchedulingTripDetails, "Id", "Id", tripBooking.SchedulingTripDetailId);
            return View(tripBooking);
        }

        // GET: Sociologist/TripBookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tripBooking = await _context.TripBookings
                .Include(t => t.City)
                .Include(t => t.SchedulingTripDetail)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tripBooking == null)
            {
                return NotFound();
            }

            return View(tripBooking);
        }

        // POST: Sociologist/TripBookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tripBooking = await _context.TripBookings.FindAsync(id);
            _context.TripBookings.Remove(tripBooking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TripBookingExists(int id)
        {
            return _context.TripBookings.Any(e => e.Id == id);
        }
    }
}
