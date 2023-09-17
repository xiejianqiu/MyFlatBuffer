// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WorldCupCountry : Table {
  public static FB_WorldCupCountry GetRootAsFB_WorldCupCountry(ByteBuffer _bb) { return GetRootAsFB_WorldCupCountry(_bb, new FB_WorldCupCountry()); }
  public static FB_WorldCupCountry GetRootAsFB_WorldCupCountry(ByteBuffer _bb, FB_WorldCupCountry obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WorldCupCountry __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_WorldCupCountry> CreateFB_WorldCupCountry(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset)) {
    builder.StartObject(3);
    FB_WorldCupCountry.AddIcon(builder, Icon);
    FB_WorldCupCountry.AddName(builder, Name);
    FB_WorldCupCountry.AddID(builder, ID);
    return FB_WorldCupCountry.EndFB_WorldCupCountry(builder);
  }

  public static void StartFB_WorldCupCountry(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static Offset<FB_WorldCupCountry> EndFB_WorldCupCountry(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WorldCupCountry>(o);
  }
};

public sealed class FB_WorldCupCountryContainer : Table {
  public static FB_WorldCupCountryContainer GetRootAsFB_WorldCupCountryContainer(ByteBuffer _bb) { return GetRootAsFB_WorldCupCountryContainer(_bb, new FB_WorldCupCountryContainer()); }
  public static FB_WorldCupCountryContainer GetRootAsFB_WorldCupCountryContainer(ByteBuffer _bb, FB_WorldCupCountryContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WorldCupCountryContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WorldCupCountryContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WorldCupCountry GetItems(int j) { return GetItems(new FB_WorldCupCountry(), j); }
  public FB_WorldCupCountry GetItems(FB_WorldCupCountry obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WorldCupCountryContainer> CreateFB_WorldCupCountryContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WorldCupCountryContainer.AddItems(builder, items);
    return FB_WorldCupCountryContainer.EndFB_WorldCupCountryContainer(builder);
  }

  public static void StartFB_WorldCupCountryContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WorldCupCountry>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WorldCupCountryContainer> EndFB_WorldCupCountryContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WorldCupCountryContainer>(o);
  }
  public static void FinishFB_WorldCupCountryContainerBuffer(FlatBufferBuilder builder, Offset<FB_WorldCupCountryContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
