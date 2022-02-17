using Assignment7.Models;

namespace Assignment7.Services;

public interface IPersonService{
  
    public List<Person> GetAll();
    public Person GetOne(int index);
    public void Create(Person person);
   
    public void Update(int index, Person person);
    
    public void Delete(int index);
}