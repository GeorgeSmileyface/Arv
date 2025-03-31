using Arv;

Doctor doctor = new Doctor("Daniel", 12345678, "drDalle@njicvsfd.dk", "Dermatologist");

Person person = new Person();

Patient patient = new Patient("Peter", 12345678, "ojfi@fj.dk", "Penecillin");

List<Person> persons = new List<Person>();
persons.Add(person);
persons.Add(patient);
persons.Add(doctor);

List<Doctor> doctors = new List<Doctor>();
doctors.Add(doctor);

if (person is Doctor doctor1)
{
    doctor1.Specialty = "Oncology";
}