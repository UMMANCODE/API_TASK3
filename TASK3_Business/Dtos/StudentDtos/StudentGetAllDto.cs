﻿namespace TASK3_Business.Dtos.StudentDtos {
  public class StudentGetAllDto {
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public int GroupId { get; set; }
  }
}
