﻿using HciMedico.Domain.Models;

namespace HciMedico.App.Services;

public interface ISearchService
{
    List<Patient>? SearchPatients(List<Patient> targetSet, string key);
}
