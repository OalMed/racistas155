using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Previewer;

Document.Create(container =>
{
    container.Page(page =>
    {
        // page content
    });
}).ShowInCompanion();