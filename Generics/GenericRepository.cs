using System;

public class GenericRepository<T>
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public List<T> GetAll()
    {
        return items;
    }

    public T GetByIndex(int index)
    {
        return items[index];
    }

    public void Update(int indexOfItemToUpdate, T newValue)
    {
        items[indexOfItemToUpdate] = newValue;
    }

    public void Delete(int index)
    {
        items.RemoveAt(index);
    }
}


/*
 * Program.cs code

//GenericRepository<string> stringRepository = new GenericRepository<string>();
//stringRepository.Add("Hi");
//stringRepository.Add("Hello");
//stringRepository.GetAll();
//stringRepository.Update(0, "Hi updated to Hellooooooooo");
//stringRepository.GetAll();

//GenericRepository<int> intRepository = new GenericRepository<int>();
//intRepository.Add(1);
//intRepository.GetAll();


GenericRepository<Person> personRepository = new GenericRepository<Person>();
personRepository.Add(new Person { Name = "Bob", Age = 10 });
personRepository.Add(new Person { Name = "Alice", Age = 12 });
foreach (var person in personRepository.GetAll()) 
{
    Console.WriteLine(person.Name + " " + person.Age);
}


*/