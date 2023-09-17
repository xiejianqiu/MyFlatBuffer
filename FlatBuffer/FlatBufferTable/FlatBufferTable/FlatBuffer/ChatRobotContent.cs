// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ChatRobotContent : Table {
  public static FB_ChatRobotContent GetRootAsFB_ChatRobotContent(ByteBuffer _bb) { return GetRootAsFB_ChatRobotContent(_bb, new FB_ChatRobotContent()); }
  public static FB_ChatRobotContent GetRootAsFB_ChatRobotContent(ByteBuffer _bb, FB_ChatRobotContent obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ChatRobotContent __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int MenPai { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Sex { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Level { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Vip { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string ChatContent { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public int ChatDistance { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ChatGroupID { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HeadPeiShiID { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ChatPeiShiID { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ChatRobotContent> CreateFB_ChatRobotContent(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int MenPai = -1,
      int Sex = -1,
      int Level = -1,
      int Vip = -1,
      StringOffset ChatContent = default(StringOffset),
      int ChatDistance = -1,
      int ChatGroupID = -1,
      int HeadPeiShiID = -1,
      int ChatPeiShiID = -1) {
    builder.StartObject(11);
    FB_ChatRobotContent.AddChatPeiShiID(builder, ChatPeiShiID);
    FB_ChatRobotContent.AddHeadPeiShiID(builder, HeadPeiShiID);
    FB_ChatRobotContent.AddChatGroupID(builder, ChatGroupID);
    FB_ChatRobotContent.AddChatDistance(builder, ChatDistance);
    FB_ChatRobotContent.AddChatContent(builder, ChatContent);
    FB_ChatRobotContent.AddVip(builder, Vip);
    FB_ChatRobotContent.AddLevel(builder, Level);
    FB_ChatRobotContent.AddSex(builder, Sex);
    FB_ChatRobotContent.AddMenPai(builder, MenPai);
    FB_ChatRobotContent.AddName(builder, Name);
    FB_ChatRobotContent.AddId(builder, Id);
    return FB_ChatRobotContent.EndFB_ChatRobotContent(builder);
  }

  public static void StartFB_ChatRobotContent(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddMenPai(FlatBufferBuilder builder, int MenPai) { builder.AddInt(2, MenPai, -1); }
  public static void AddSex(FlatBufferBuilder builder, int Sex) { builder.AddInt(3, Sex, -1); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(4, Level, -1); }
  public static void AddVip(FlatBufferBuilder builder, int Vip) { builder.AddInt(5, Vip, -1); }
  public static void AddChatContent(FlatBufferBuilder builder, StringOffset ChatContentOffset) { builder.AddOffset(6, ChatContentOffset.Value, 0); }
  public static void AddChatDistance(FlatBufferBuilder builder, int ChatDistance) { builder.AddInt(7, ChatDistance, -1); }
  public static void AddChatGroupID(FlatBufferBuilder builder, int ChatGroupID) { builder.AddInt(8, ChatGroupID, -1); }
  public static void AddHeadPeiShiID(FlatBufferBuilder builder, int HeadPeiShiID) { builder.AddInt(9, HeadPeiShiID, -1); }
  public static void AddChatPeiShiID(FlatBufferBuilder builder, int ChatPeiShiID) { builder.AddInt(10, ChatPeiShiID, -1); }
  public static Offset<FB_ChatRobotContent> EndFB_ChatRobotContent(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChatRobotContent>(o);
  }
};

public sealed class FB_ChatRobotContentContainer : Table {
  public static FB_ChatRobotContentContainer GetRootAsFB_ChatRobotContentContainer(ByteBuffer _bb) { return GetRootAsFB_ChatRobotContentContainer(_bb, new FB_ChatRobotContentContainer()); }
  public static FB_ChatRobotContentContainer GetRootAsFB_ChatRobotContentContainer(ByteBuffer _bb, FB_ChatRobotContentContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ChatRobotContentContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ChatRobotContentContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ChatRobotContent GetItems(int j) { return GetItems(new FB_ChatRobotContent(), j); }
  public FB_ChatRobotContent GetItems(FB_ChatRobotContent obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ChatRobotContentContainer> CreateFB_ChatRobotContentContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ChatRobotContentContainer.AddItems(builder, items);
    return FB_ChatRobotContentContainer.EndFB_ChatRobotContentContainer(builder);
  }

  public static void StartFB_ChatRobotContentContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ChatRobotContent>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ChatRobotContentContainer> EndFB_ChatRobotContentContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChatRobotContentContainer>(o);
  }
  public static void FinishFB_ChatRobotContentContainerBuffer(FlatBufferBuilder builder, Offset<FB_ChatRobotContentContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
