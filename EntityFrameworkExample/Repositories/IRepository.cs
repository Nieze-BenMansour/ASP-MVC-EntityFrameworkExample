﻿using EntityFrameworkExample.Models;

namespace EntityFrameworkExample.Repositories;

public interface IRepository
{
    IEnumerable<Person> GetPeople();
    void CreatePerson();
    void UpdatePerson(int id);
    void DeletePerson(int id);

}
