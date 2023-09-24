namespace Figma.Presentation.Services
{
    public interface IQuestionsServices
    {
        void Create(QuestionsDto dto);
        void update(int id, QuestionsDto dto);
        void Delete(int id);
        Question GetById(int id);
    }
}
