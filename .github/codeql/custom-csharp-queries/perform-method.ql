/**
 * @name Perform method
 * @description Method name Perform should not be used.
 * @kind problem
 * @problem.severity warning
 * @precision high
 * @id cs/custom-perform-method
 * @tags maintainability
 */

import csharp

from Method m
where m.getName() = "Perform"
select m, "Method name 'Perform' should not be used."