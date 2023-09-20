namespace sample
{
  internal class SomeClass
  {
    // No Params
    public SomeClass()
    {
    }

    /// <summary>
    /// Some Class CTOR
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    public SomeClass(int id, string name)
    {
      // Throw REMOVE comments
      this.Id = id;
      this.Name = name;
    }

    public int Id { get; set; }
    public string? Name { get; set; }
  }
}