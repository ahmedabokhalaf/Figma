namespace Figma.Presentation.Services
{
    public class QuestionsServices : IQuestionsServices
    {
        private readonly IUnitOfWork unitOfWork;

        public QuestionsServices(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Create(QuestionsDto dto)
        {
            Question question = new()
            {
                Type = dto.Type,
                QuestionFormula = dto.QuestionFormula
            };
            unitOfWork.Questions.Create(question);
            unitOfWork.Save();
        }

        public void Delete(int id)
        {
            var question = unitOfWork.Questions.Get(id);
            if (question != null)
            {
                unitOfWork.Questions.Delete(question);
                unitOfWork.Save();
            }
        }

        public Question GetById(int id)
        {
            return unitOfWork.Questions.Get(id);
        }

        public void update(int id, QuestionsDto dto)
        {
            var question = unitOfWork.Questions.Get(id);
            if (question != null)
            {
                question.Type = dto.Type;
                question.QuestionFormula = dto.QuestionFormula;
                unitOfWork.Questions.Update(question);
                unitOfWork.Save();
            }
        }
    }
}
