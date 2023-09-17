// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ItemCompoundTypeSetting : Table {
  public static FB_ItemCompoundTypeSetting GetRootAsFB_ItemCompoundTypeSetting(ByteBuffer _bb) { return GetRootAsFB_ItemCompoundTypeSetting(_bb, new FB_ItemCompoundTypeSetting()); }
  public static FB_ItemCompoundTypeSetting GetRootAsFB_ItemCompoundTypeSetting(ByteBuffer _bb, FB_ItemCompoundTypeSetting obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ItemCompoundTypeSetting __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FunctionOpenID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string DefaultIcon { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public string SelectIcon { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_ItemCompoundTypeSetting> CreateFB_ItemCompoundTypeSetting(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int FunctionOpenID = -1,
      StringOffset DefaultIcon = default(StringOffset),
      StringOffset SelectIcon = default(StringOffset)) {
    builder.StartObject(5);
    FB_ItemCompoundTypeSetting.AddSelectIcon(builder, SelectIcon);
    FB_ItemCompoundTypeSetting.AddDefaultIcon(builder, DefaultIcon);
    FB_ItemCompoundTypeSetting.AddFunctionOpenID(builder, FunctionOpenID);
    FB_ItemCompoundTypeSetting.AddName(builder, Name);
    FB_ItemCompoundTypeSetting.AddID(builder, ID);
    return FB_ItemCompoundTypeSetting.EndFB_ItemCompoundTypeSetting(builder);
  }

  public static void StartFB_ItemCompoundTypeSetting(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddFunctionOpenID(FlatBufferBuilder builder, int FunctionOpenID) { builder.AddInt(2, FunctionOpenID, -1); }
  public static void AddDefaultIcon(FlatBufferBuilder builder, StringOffset DefaultIconOffset) { builder.AddOffset(3, DefaultIconOffset.Value, 0); }
  public static void AddSelectIcon(FlatBufferBuilder builder, StringOffset SelectIconOffset) { builder.AddOffset(4, SelectIconOffset.Value, 0); }
  public static Offset<FB_ItemCompoundTypeSetting> EndFB_ItemCompoundTypeSetting(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ItemCompoundTypeSetting>(o);
  }
};

public sealed class FB_ItemCompoundTypeSettingContainer : Table {
  public static FB_ItemCompoundTypeSettingContainer GetRootAsFB_ItemCompoundTypeSettingContainer(ByteBuffer _bb) { return GetRootAsFB_ItemCompoundTypeSettingContainer(_bb, new FB_ItemCompoundTypeSettingContainer()); }
  public static FB_ItemCompoundTypeSettingContainer GetRootAsFB_ItemCompoundTypeSettingContainer(ByteBuffer _bb, FB_ItemCompoundTypeSettingContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ItemCompoundTypeSettingContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ItemCompoundTypeSettingContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ItemCompoundTypeSetting GetItems(int j) { return GetItems(new FB_ItemCompoundTypeSetting(), j); }
  public FB_ItemCompoundTypeSetting GetItems(FB_ItemCompoundTypeSetting obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ItemCompoundTypeSettingContainer> CreateFB_ItemCompoundTypeSettingContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ItemCompoundTypeSettingContainer.AddItems(builder, items);
    return FB_ItemCompoundTypeSettingContainer.EndFB_ItemCompoundTypeSettingContainer(builder);
  }

  public static void StartFB_ItemCompoundTypeSettingContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ItemCompoundTypeSetting>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ItemCompoundTypeSettingContainer> EndFB_ItemCompoundTypeSettingContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ItemCompoundTypeSettingContainer>(o);
  }
  public static void FinishFB_ItemCompoundTypeSettingContainerBuffer(FlatBufferBuilder builder, Offset<FB_ItemCompoundTypeSettingContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
