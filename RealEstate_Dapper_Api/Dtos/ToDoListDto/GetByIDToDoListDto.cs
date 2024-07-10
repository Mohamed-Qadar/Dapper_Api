namespace RealEstate_Dapper_Api.Dtos.ToDoListDto
{
    public class GetByIDToDoListDto
    {
        public int ToDoListID { get; set; }
        public string Description { get; set; }
        public bool ToDoListStatus { get; set; }
    }
}
