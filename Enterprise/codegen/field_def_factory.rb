require_relative 'constants'
require_relative 'primitive_field_def'
require_relative 'collection_field_def'
require_relative 'enum_field_def'
require_relative 'component_field_def'
require_relative 'entity_field_def'
require_relative 'user_type_field_def'
require_relative 'type_name_utils'
require_relative 'extended_properties_field_def'

# Factory class to create FieldDef subclasses of the correct type, based upon the specified fieldNode
class FieldDefFactory
  
  # Creates a FieldDef subclass based on the specified fieldNode
  def FieldDefFactory.CreateFieldDef(model, fieldNode, defaultNamespace)
    # what kind of field is this?
    if(NHIBERNATE_COLLECTION_TYPES.include?(fieldNode.name))
      return fieldNode.attributes['name'] == "ExtendedProperties" ?
		ExtendedPropertiesFieldDef.new(model, fieldNode, defaultNamespace) :
			CollectionFieldDef.new(model, fieldNode, defaultNamespace)
    elsif(['many-to-one', 'one-to-one'].include?(fieldNode.name))
      return EntityFieldDef.new(model, fieldNode, defaultNamespace)
    elsif(fieldNode.name == 'component' || fieldNode.name == 'nested-composite-element')
      return ComponentFieldDef.new(model, fieldNode, defaultNamespace)
    elsif(TypeNameUtils.isEnumHbm(fieldNode.attributes['type']))
      return EnumFieldDef.new(model, fieldNode)
    elsif(TypeNameUtils.isHbm(fieldNode.attributes['type']))
      return UserTypeFieldDef.new(model, fieldNode)
    else
      return PrimitiveFieldDef.new(model, fieldNode)
    end
    
  end
end
