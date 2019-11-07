﻿// ********************************************************************************************************************************************
// Copyright (c) 2019
// Author: USA
// Product: CHILI
// Version: 1.0.0
// ********************************************************************************************************************************************

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Usa.chili.Services;

namespace Usa.chili.Web.Controllers
{
    [Route("[controller]")]
    public class DataController : Controller
    {
        private readonly ILogger _logger;
        private readonly IStationService _stationService;
        private readonly IStationDataService _stationDataService;
        private readonly IPublicService _publicService;

        public DataController(
            ILogger<DataController> logger,
            IStationService stationService,
            IStationDataService stationDataService,
            IPublicService publicService)
        {
            _logger = logger;
            _stationService = stationService;
            _stationDataService = stationDataService;
            _publicService = publicService;
        }

        [HttpGet("Realtime")]
        public IActionResult Realtime()
        {
            return View();
        }

        [HttpGet("RealtimeData")]
        public async Task<IActionResult> RealtimeData()
        {
            return new JsonResult(await _stationDataService.ListRealtimeData());
        }

        [HttpGet("CustomProducts")]
        public IActionResult CustomProducts()
        {
            return View();
        }

        [HttpGet("Metadata")]
        public IActionResult Metadata(int? id) => View();

        [HttpGet("Station")]
        public IActionResult Station(int? id)
        {
            return View();
        }

        [HttpGet("StationMap")]
        public async Task<IActionResult> StationMap()
        {
            return new JsonResult(await _stationService.GetStationMapData());
        }

        [HttpGet("Graph")]
        public IActionResult Graph()
        {
            return View();
        }

        [HttpGet("Meteorological")]
        public IActionResult Meteorological()
        {
            return View();
        }

        [HttpGet("QC_Graphs")]
        public IActionResult QC_Graphs()
        {
            return View();
        }

        [HttpGet("Summaries")]
        public IActionResult Summaries()
        {
            return View();
        }

        [HttpGet("VOC")]
        public IActionResult VOC()
        {
            return View();
        }

        [HttpGet("ActiveStationList")]
        public async Task<IActionResult> ActiveStationList()
        {
            return new JsonResult(await _stationService.ListActiveStations());
        }

        [HttpGet("StationList")]
        public async Task<IActionResult> StationList()
        {
            return new JsonResult(await _stationService.ListAllStations());
        }

        [HttpGet("StationObservation")]
        public async Task<IActionResult> StationObservationData(int id)
        {
            return new JsonResult(await _publicService.GetStationObservationById(id));
        }
    }
}