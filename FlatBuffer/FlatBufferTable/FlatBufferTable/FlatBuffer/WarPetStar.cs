// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WarPetStar : Table {
  public static FB_WarPetStar GetRootAsFB_WarPetStar(ByteBuffer _bb) { return GetRootAsFB_WarPetStar(_bb, new FB_WarPetStar()); }
  public static FB_WarPetStar GetRootAsFB_WarPetStar(ByteBuffer _bb, FB_WarPetStar obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WarPetStar __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetStarExpList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int StarExpListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetStar> CreateFB_WarPetStar(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset StarExpList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_WarPetStar.AddStarExpList(builder, StarExpList);
    FB_WarPetStar.AddName(builder, Name);
    FB_WarPetStar.AddID(builder, ID);
    return FB_WarPetStar.EndFB_WarPetStar(builder);
  }

  public static void StartFB_WarPetStar(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddStarExpList(FlatBufferBuilder builder, VectorOffset StarExpListOffset) { builder.AddOffset(2, StarExpListOffset.Value, 0); }
  public static VectorOffset CreateStarExpListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartStarExpListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetStar> EndFB_WarPetStar(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetStar>(o);
  }
};

public sealed class FB_WarPetStarContainer : Table {
  public static FB_WarPetStarContainer GetRootAsFB_WarPetStarContainer(ByteBuffer _bb) { return GetRootAsFB_WarPetStarContainer(_bb, new FB_WarPetStarContainer()); }
  public static FB_WarPetStarContainer GetRootAsFB_WarPetStarContainer(ByteBuffer _bb, FB_WarPetStarContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WarPetStarContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WarPetStarContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WarPetStar GetItems(int j) { return GetItems(new FB_WarPetStar(), j); }
  public FB_WarPetStar GetItems(FB_WarPetStar obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetStarContainer> CreateFB_WarPetStarContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WarPetStarContainer.AddItems(builder, items);
    return FB_WarPetStarContainer.EndFB_WarPetStarContainer(builder);
  }

  public static void StartFB_WarPetStarContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WarPetStar>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetStarContainer> EndFB_WarPetStarContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetStarContainer>(o);
  }
  public static void FinishFB_WarPetStarContainerBuffer(FlatBufferBuilder builder, Offset<FB_WarPetStarContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
