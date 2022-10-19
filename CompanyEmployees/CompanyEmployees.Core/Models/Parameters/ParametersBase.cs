namespace CompanyEmployees.Core.Models.Parameters;

public abstract class ParametersBase
{
    private int _pageNumber = 1;
    public int PageNumber
    {
        get
        {
            return _pageNumber;
        }
        set
        {
            _pageNumber = (value < 1) ? 1 : value;
        }
    }

    private const int MAX_PAGE_SIZE = 50;
    private int _pageSize = 12;
    public int PageSize
    {
        get
        {
            return _pageSize;
        }
        set
        {
            _pageSize = (value < 1) ? 1 : value;
            _pageSize = (_pageSize > MAX_PAGE_SIZE) ? MAX_PAGE_SIZE : _pageSize;
        }
    }

    public string? SearchTerm { get; set; }
    public string? OrderBy { get; set; }
}
