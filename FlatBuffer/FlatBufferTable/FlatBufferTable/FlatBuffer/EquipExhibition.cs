// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipExhibition : Table {
  public static FB_EquipExhibition GetRootAsFB_EquipExhibition(ByteBuffer _bb) { return GetRootAsFB_EquipExhibition(_bb, new FB_EquipExhibition()); }
  public static FB_EquipExhibition GetRootAsFB_EquipExhibition(ByteBuffer _bb, FB_EquipExhibition obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipExhibition __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int OwnProrobability { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetMenPaiList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MenPaiListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipExhibition> CreateFB_EquipExhibition(FlatBufferBuilder builder,
      int Id = 0,
      int OwnProrobability = -1,
      VectorOffset MenPaiList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_EquipExhibition.AddMenPaiList(builder, MenPaiList);
    FB_EquipExhibition.AddOwnProrobability(builder, OwnProrobability);
    FB_EquipExhibition.AddId(builder, Id);
    return FB_EquipExhibition.EndFB_EquipExhibition(builder);
  }

  public static void StartFB_EquipExhibition(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddOwnProrobability(FlatBufferBuilder builder, int OwnProrobability) { builder.AddInt(1, OwnProrobability, -1); }
  public static void AddMenPaiList(FlatBufferBuilder builder, VectorOffset MenPaiListOffset) { builder.AddOffset(2, MenPaiListOffset.Value, 0); }
  public static VectorOffset CreateMenPaiListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMenPaiListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipExhibition> EndFB_EquipExhibition(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipExhibition>(o);
  }
};

public sealed class FB_EquipExhibitionContainer : Table {
  public static FB_EquipExhibitionContainer GetRootAsFB_EquipExhibitionContainer(ByteBuffer _bb) { return GetRootAsFB_EquipExhibitionContainer(_bb, new FB_EquipExhibitionContainer()); }
  public static FB_EquipExhibitionContainer GetRootAsFB_EquipExhibitionContainer(ByteBuffer _bb, FB_EquipExhibitionContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipExhibitionContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipExhibitionContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipExhibition GetItems(int j) { return GetItems(new FB_EquipExhibition(), j); }
  public FB_EquipExhibition GetItems(FB_EquipExhibition obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipExhibitionContainer> CreateFB_EquipExhibitionContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipExhibitionContainer.AddItems(builder, items);
    return FB_EquipExhibitionContainer.EndFB_EquipExhibitionContainer(builder);
  }

  public static void StartFB_EquipExhibitionContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipExhibition>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipExhibitionContainer> EndFB_EquipExhibitionContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipExhibitionContainer>(o);
  }
  public static void FinishFB_EquipExhibitionContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipExhibitionContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
