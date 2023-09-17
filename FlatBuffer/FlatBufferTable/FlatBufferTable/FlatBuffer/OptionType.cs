// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_OptionType : Table {
  public static FB_OptionType GetRootAsFB_OptionType(ByteBuffer _bb) { return GetRootAsFB_OptionType(_bb, new FB_OptionType()); }
  public static FB_OptionType GetRootAsFB_OptionType(ByteBuffer _bb, FB_OptionType obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_OptionType __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetOptionList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int OptionListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_OptionType> CreateFB_OptionType(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset OptionList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_OptionType.AddOptionList(builder, OptionList);
    FB_OptionType.AddName(builder, Name);
    FB_OptionType.AddId(builder, Id);
    return FB_OptionType.EndFB_OptionType(builder);
  }

  public static void StartFB_OptionType(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddOptionList(FlatBufferBuilder builder, VectorOffset OptionListOffset) { builder.AddOffset(2, OptionListOffset.Value, 0); }
  public static VectorOffset CreateOptionListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartOptionListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_OptionType> EndFB_OptionType(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OptionType>(o);
  }
};

public sealed class FB_OptionTypeContainer : Table {
  public static FB_OptionTypeContainer GetRootAsFB_OptionTypeContainer(ByteBuffer _bb) { return GetRootAsFB_OptionTypeContainer(_bb, new FB_OptionTypeContainer()); }
  public static FB_OptionTypeContainer GetRootAsFB_OptionTypeContainer(ByteBuffer _bb, FB_OptionTypeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_OptionTypeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_OptionTypeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_OptionType GetItems(int j) { return GetItems(new FB_OptionType(), j); }
  public FB_OptionType GetItems(FB_OptionType obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_OptionTypeContainer> CreateFB_OptionTypeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_OptionTypeContainer.AddItems(builder, items);
    return FB_OptionTypeContainer.EndFB_OptionTypeContainer(builder);
  }

  public static void StartFB_OptionTypeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_OptionType>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_OptionTypeContainer> EndFB_OptionTypeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OptionTypeContainer>(o);
  }
  public static void FinishFB_OptionTypeContainerBuffer(FlatBufferBuilder builder, Offset<FB_OptionTypeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
