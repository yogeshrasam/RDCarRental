/**
 * @name ResumeWorkflow method
 * @description ResumeWorkflow should not be changed.
 * @kind problem
 * @problem.severity warning
 * @precision high
 * @id cs/custom-ResumeWorkflow
 * @tags maintainability
 */

import csharp

// Define the class and method we want to analyze
class FacadeServiceContext extends Class {
  FacadeServiceContext() {
    this.hasName("FacadeServiceContext")
  }
  
  // Define the ResumeWorkflow method with 2 parameters
  Method resumeWorkflow() {
    result = this.getMethod("ResumeWorkflow")
    result.getNumberOfParameters() = 2
  }
}

// Query for any changes to the ResumeWorkflow method
from FacadeServiceContext fsc, Method m
where fsc.resumeWorkflow() = m and
      exists(int diff |
        m.getAnnotatedDiff(diff) and
        diff.getAnnotatedChanges().matches(".*")
      )
select m, "Changes detected in ResumeWorkflow method."