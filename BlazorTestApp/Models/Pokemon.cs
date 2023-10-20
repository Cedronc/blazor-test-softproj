using System;

namespace BlazorTestApp.Models;

public class Pokemon
{
    public int Id { get; set; }
    public string Name { get; set; }
	public Sprites sprites { get; set; }
	public int height { get; set; }
	public int weight { get; set; }
}

public class Sprites
{
	public string back_default { get; set; }
	public object back_female { get; set; }
	public string back_shiny { get; set; }
	public object back_shiny_female { get; set; }
	public string front_default { get; set; }
	public object front_female { get; set; }
	public string front_shiny { get; set; }
	public object front_shiny_female { get; set; }
}

