﻿using System;
using Conditions.DTOs;
using WellFormedNames;

namespace ActionLibrary.DTOs
{
    /// <summary>
    /// Data Type Object Class for defining an Action.
    /// </summary>
    [Serializable]
    public class ActionRuleDTO
	{
		/// <summary>
		/// The unique identifier of the action that this DTO is describing
		/// </summary>
		public Guid Id { get; set; }
		/// <summary>
		/// The action template, as a well formed string.
		/// </summary>
		/// <example>
		/// Attack([type],[strength])
		/// </example>
		public Name Action { get; set; }
		/// <summary>
		/// The target of the action, if any.
		/// </summary>
		public Name Target { get; set; }
        /// <summary>
		/// The priority of the action.
		/// </summary>
        public Name Priority { get; set; }
        /// <summary>
        /// The layer associated to the action (e.g. verbal, nonverbal)
        /// </summary>
        public Name Layer { get; set; }
        /// <summary>
        /// The set of conditions that must be true for this action execution.
        /// </summary>
        public ConditionSetDTO Conditions { get; set; }
	}
}