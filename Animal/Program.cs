using Animal;
Veterinarian vet = new Veterinarian();
Animal1 cat = new Cat();
Animal1 dog = new Dog();
Animal1 hor = new Horse();
List<Animal1> animal = new List<Animal1>() { cat, dog, hor };
for(int i = 0; i < 3; i++)
{
    vet.TreatAnimal(animal[i]);
}
