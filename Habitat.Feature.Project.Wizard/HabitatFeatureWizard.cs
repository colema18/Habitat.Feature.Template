using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;

namespace Habitat.Feature.Project.Wizard
{
    class HabitatFeatureWizard : IWizard
    {
        private DTE _dte;
        private UserInputForm _inputForm;
        private string _featureName;

        public void BeforeOpeningFile(ProjectItem projectItem) { }
        public void ProjectFinishedGenerating(EnvDTE.Project project) { }
        public void ProjectItemFinishedGenerating(ProjectItem projectItem) { }
        public void RunFinished() { }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            _dte = (DTE)automationObject;

            try
            {
                _inputForm = new UserInputForm();
                _inputForm.ShowDialog();
                _featureName = _inputForm.FeatureName;

                replacementsDictionary.Add("$featureName$", _featureName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public bool ShouldAddProjectItem(string filePath) { return true; }
    }
}
