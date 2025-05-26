namespace EllaManka.Contracts
{
    public interface IAssignmentContract
    {
        void CreateAssignment(Assignment assignment);
        void UpdateAssignment(int assignmentId, Assignment assignment);
        Assignment GetAssignment(int assignmentId);
    }
}