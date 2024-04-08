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
  
  Method resumeWorkflow() {
    this.getMethod("ResumeWorkflow")
  }
}

from FacadeServiceContext fsc, Method m
where fsc.resumeWorkflow() = m and
      exists(DiffEntry de |
        m.getAnnotatedDiff().getDiffEntry(de) and
        de.getChangeType() != DiffEntry::ChangeType::MODIFIED and
        de.getChangeType() != DiffEntry::ChangeType::UNCHANGED
      )
select m, "Changes detected in ResumeWorkflow method."