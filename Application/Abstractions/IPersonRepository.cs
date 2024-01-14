﻿using Domain.Entities;

namespace Application.Abstractions;

public interface IPersonRepository
{
    Task<ICollection<Person>> GetAll();

    Task<Person> GetPersonById(int personId);

    Task<Person> AddPerson(Person toCreate);

    Task<Person> UpdatePerson(int personId, string name, string email);

    Task DeletePerson(int personId);
};