namespace DemoApi31.Repository
{
    public interface MainInterface<T> where T : class
    {
        IEnumerable<T> GetAllDate();
        T GetRowId(int id);
        void AddRow(T modle);
        void UpdateRow(T modle);
        void DeleteRow(int id);


    }
}
