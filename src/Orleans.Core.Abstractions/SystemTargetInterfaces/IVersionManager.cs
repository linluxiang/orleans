using System.Threading.Tasks;
using Orleans.Runtime;
using Orleans.Versions.Compatibility;
using Orleans.Versions.Selector;

namespace Orleans
{
    public interface IVersionManager
    {
        /// <summary>
        /// Set the compatibility strategy
        /// </summary>
        /// <param name="strategy">The strategy to set. Set to null to revert to the default strategy provided in configuration</param>
        /// <returns></returns>
        Task SetCompatibilityStrategy(CompatibilityStrategy strategy);

        /// <summary>
        /// Set the selector strategy
        /// </summary>
        /// <param name="strategy">The strategy to set. Set to null to revert to the default strategy provided in configuration</param>
        /// <returns></returns>
        Task SetSelectorStrategy(VersionSelectorStrategy strategy);

        /// <summary>
        /// Set the compatibility strategy for a specific interface
        /// </summary>
        /// <param name="interfaceType">The type of the interface</param>
        /// <param name="strategy">The strategy to set. Set to null to revert to the default strategy provided in configuration</param>
        /// <returns></returns>
        Task SetCompatibilityStrategy(GrainInterfaceType interfaceType, CompatibilityStrategy strategy);

        /// <summary>
        /// Set the selector strategy for a specific interface
        /// </summary>
        /// <param name="interfaceType">The type of the interface</param>
        /// <param name="strategy">The strategy to set. Set to null to revert to the default strategy provided in configuration</param>
        /// <returns></returns>
        Task SetSelectorStrategy(GrainInterfaceType interfaceType, VersionSelectorStrategy strategy);
    }
}